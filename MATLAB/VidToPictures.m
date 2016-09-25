function [ output_args ] = VidToPictures( str_vidName )
%UNTITLED3 Summary of this function goes here
%   Detailed explanation goes here

%Make the appropriate directory
fpath = './VidtPic/';
index = 0;
ffull = strcat(strcat(fpath, str_vidName), int2str(index));
while exist(ffull, 'dir')
    index = index + 1;
    ffull = strcat(strcat(fpath, str_vidName), int2str(index));
end
mkdir(ffull);

%Copies the video to new directory and deletes old one.
path1 = strcat('./VidtPic/', str_vidName);
copyfile(path1, ffull);
delete(path1);

%Video files must be in the VidtPic folder. Then you can create the
%pictures.
newVidPath = strcat(ffull, '/');
vidPath = strcat(newVidPath, str_vidName);
pVideo = VideoReader(vidPath);
idx = 0; %Image index
while hasFrame(pVideo)
   img = readFrame(pVideo);
   filename = strcat(strcat(str_vidName, int2str(idx)), '.jpg');
   fullname = strcat(strcat(ffull, '/'), filename);
   imwrite(img, fullname);
   idx = idx + 1;
end
end

