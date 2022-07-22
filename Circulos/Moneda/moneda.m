function moneda()
clc;
moneda1 = im2bw(imread('img01.jpg'));
if size(moneda1,3)==3  % es RGB?
        moneda1= rgb2gray(moneda1);
    end
moneda2 = imfill(moneda1,'holes');

[L Ne]=bwlabel(double(moneda2));

prop=regionprops(L,'Area','Centroid');
total=0;
imshow(imread('img01.jpg'));hold on

%Calcular las monedas
for n=1:size(prop,1) 
    moneda=prop(n).Centroid;
    X=moneda(1);Y=moneda(2);
    if prop(n).Area>1000
        text(X-10,Y,'10') 
        total=total+5;
    else
        total=total+10;
        text(X-10,Y,'5') 
    

    end
end
hold on
title(['Total de dinero: ',num2str(total),'  '])

end
