
##Importar los paquetes necesarios##
import matplotlib.pyplot as plt
import matplotlib.image as mpimg
import cv2

cr=cv2.getStructuringElement(cv2.MORPH_ELLIPSE,(9,9))
frm=plt.figure()
img = mpimg.imread("puntos_lineas.jpg")
gary = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
a=frm.add_subplot(1,2,1)
imgplot = plt.imshow(img)
a=frm.add_subplot(1,2,2)
imop=cv2.morphologyEx(img,cv2.MORPH_OPEN,cr)
imgplot = plt.imshow(imop)


##Mostrar la imagen##
plt.show()
