import cv2
import numpy as np
import matplotlib.pyplot as plt
 
I	= cv2.imread('carro.jpg')
gray_img	=	cv2.cvtColor(I,	cv2.COLOR_BGR2GRAY)
img	= cv2.medianBlur(gray_img,	5)
cimg = cv2.cvtColor(img,cv2.COLOR_GRAY2BGR)
 
#center
#para la imgaen carro.jpg
circulo	= cv2.HoughCircles(img,cv2.HOUGH_GRADIENT,3,800,param1=800,param2=125,minRadius=190,maxRadius=280)

#para la imagen carroBlanco.jpg  
#circulo	= cv2.HoughCircles(img,cv2.HOUGH_GRADIENT,7,400,param1=800,param2=125,minRadius=0,maxRadius=127)

circulo	= np.uint16(np.around(circulo))
 
for	i in circulo[0,:]:
				#se dibuja el circulo interior
				cv2.circle(I,(i[0],i[1]),i[2],(0,255,0),6)
				#	se dibuja el centro del circulo
				cv2.circle(I,(i[0],i[1]),2,(0,0,255),3)
 
plt.imshow(I)
cv2.waitKey()
cv2.destroyAllWindows()