str = fileread('C:\Users\wildcat\Documents\Senior-Project\OpenFace-master\OpenFace-master\output\horacio_det_0.pts')
ary = strsplit(str,'\n');
x = [];
y = [];
output = '';
for idx = 4:71
    element = ary(idx);
    temp = strsplit(char(element), ' ');
    x = vertcat(x,temp(2));
    y = vertcat(y,temp(1));
end
x1=zeros(size(x,1),size(x,2));
x1=str2double(x);
y1=zeros(size(y,1),size(y,2));
y1=str2double(y);
tri = delaunayTriangulation(x1,y1);

triplot(tri);
