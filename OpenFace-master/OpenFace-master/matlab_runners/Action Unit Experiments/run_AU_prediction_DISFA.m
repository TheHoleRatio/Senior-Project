clear
DISFA_dir = 'D:/Datasets/DISFA/Videos_LeftCamera/';
executable = '"../../x64/Release/FeatureExtraction.exe"';

videos = dir([DISFA_dir, '*.avi']);

output = 'out_DISFA/';
if(~exist(output, 'file'))
    mkdir(output);
end

%%
% Do it in parrallel for speed (replace the parfor with for if no parallel
% toolbox is available)
parfor v = 1:numel(videos)
   
    vid_file = [DISFA_dir, videos(v).name];
    
    [~, name, ~] = fileparts(vid_file);
    
    % where to output tracking results
    output_file = [output name '_au.txt'];
    command = [executable ' -f "' vid_file '" -of "' output_file '" -q -no2Dfp -no3Dfp -noMparams -noPose -noGaze'];
        
    dos(command);
    
end

%% Now evaluate the predictions

% Note that DISFA was used in training, this is not meant for experimental
% results but rather to show how to do AU prediction and how to interpret
% the results

Label_dir = 'D:/Datasets/DISFA/ActionUnit_Labels/';
prediction_dir = 'out_DISFA/';

label_folders = dir([Label_dir, 'SN*']);

AUs_disfa = [1,2,4,5,6,9,12,15,17,20,25,26];
labels_all = [];
label_ids = [];
for i=1:numel(label_folders)

    labels = [];
    for au = AUs_disfa
        in_file = sprintf('%s/%s/%s_au%d.txt', Label_dir, label_folders(i).name, label_folders(i).name, au);
        A = dlmread(in_file, ',');
        labels = cat(2, labels, A(:,2));
    end
    
    labels_all = cat(1, labels_all, labels);
    user_id = str2num(label_folders(i).name(3:end));
    label_ids = cat(1, label_ids, repmat(user_id, size(labels,1),1));
end

preds_files = dir([prediction_dir, '*SN*.txt']);

tab = readtable([prediction_dir, preds_files(1).name]);
column_names = tab.Properties.VariableNames;
aus_pred_int = [];
for c=3:numel(column_names)
    if(strfind(column_names{c}, '_r') > 0)
        aus_pred_int = cat(1, aus_pred_int, int32(str2num(column_names{c}(3:end-2))));
    end
end
    
inds_au = zeros(numel(AUs_disfa),1);

for ind=1:numel(AUs_disfa)  
    inds_au(ind) = find(aus_pred_int==AUs_disfa(ind));
end
preds_all = zeros(size(labels_all,1), numel(AUs_disfa));

for i=1:numel(preds_files)
   
    preds = dlmread([prediction_dir, preds_files(i).name], ',', 1, 0);
    preds = preds(:,5:5+numel(aus_pred_int)-1);

    user_id = str2num(preds_files(i).name(end - 14:end-12));
    rel_ids = label_ids == user_id;
    preds_all(rel_ids,:) = preds(:,inds_au);
end

%% now do the actual evaluation that the collection has been done
f = fopen('results/DISFA_valid_res.txt', 'w');
au_res = zeros(1, numel(AUs_disfa));
for au = 1:numel(AUs_disfa)
   [ accuracies, F1s, corrs, ccc, rms, classes ] = evaluate_au_prediction_results( preds_all(:,au), labels_all(:,au));
   fprintf(f, 'AU%d results - corr %.3f, rms %.3f, ccc - %.3f\n', AUs_disfa(au), corrs, rms, ccc);
   au_res(au) = ccc;
end
fclose(f);