clc
close all

% 1.Lee una imagen en el espacio de trabajo de MATLAB.
I  = imread("casa.jpg");
I = rgb2gray(I);

% 2. Convierte a imagen binaria
T = graythresh(I);
I1= imbinarize(I, T);
I = ~I1;

% 3.Encuentra los bordes en la imagen.
BW = edge(I,'Canny');
imshow(BW)

% 4.Calcule la transformada estandar de Hough de la imagen usando la funcion hough.
% [H,T,R] = hough(BW);    % matriz, theta, rho
% Theta value for the corresponding column of the output matrix H, 
% specified as a real, numeric vector within the range [-90, 90).
%%                                           -40 1 40
[H,T,R] = hough(BW,'RhoResolution',1,'Theta',-40:1:40); % limita la inclinacion de las lineas

% 5.Muestra el espacio de Hough
figure, imshow(H,[],'XData',T,'YData',R,...
            'InitialMagnification','fit');
xlabel('\theta'), ylabel('\rho');
axis on, axis normal, hold on;

% 6.Encuentra los picos en la matriz de la transformada de Hough H, usando la funcion de houghpeaks.
P  = houghpeaks(H,10,'threshold',ceil(0.6*max(H(:))));

% 7.Traza los picos.
x =  T(P(:,2)); % theta
y = R(P(:,1)); % Rho
plot(x,y,'s','color','white');

% 8.Encuentra lineas en la imagen usando la función houghlines.
lines = houghlines(BW,T,R,P,'FillGap',25,'MinLength',50);

% 9.Crea una grafica que superponga las lineas en la imagen original.
figure, imshow(BW), hold on
max_len = 0;
for k = 1:length(lines)
   xy = [lines(k).point1; lines(k).point2];
   plot(xy(:,1),xy(:,2),'LineWidth',2,'Color','green');

   % Plot beginnings and ends of lines
   %plot(xy(1,1),xy(1,2),'x','LineWidth',2,'Color','yellow');
   %plot(xy(2,1),xy(2,2),'x','LineWidth',2,'Color','red');

   % Determine the endpoints of the longest line segment
   len = norm(lines(k).point1 - lines(k).point2);
   if ( len > max_len)
      max_len = len;
      xy_long = xy;
   end
end

% resalta el segmento de linea mas largo
plot(xy_long(:,1),xy_long(:,2),'LineWidth',2,'Color','cyan');
