img = imread('estado-ojos.jpg');
%img=rgb2gray(img);
img=im2gray(img);
bw = edge(img,'canny');  %sobel para clavos y canny para lo demás
imshow(img)
% Encuentra todos los círculos con píxeles de radio en el rango [15, 30].r
[centers, radii, metric] = imfindcircles(bw, [28 80]);

% Dibuje los cinco perímetros de círculo más fuertes sobre la imagen original.
viscircles(centers, radii,'EdgeColor','green');

% Estas dos últimas es para que me detecten los dos circulos para la imagen
% comentarle si solo se quiere ver el circulo mas grande

[centers, radii, metric] = imfindcircles(bw, [10 27]);
viscircles(centers, radii,'EdgeColor','blue');
