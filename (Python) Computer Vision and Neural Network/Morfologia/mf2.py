import matplotlib.pyplot as plt
import matplotlib.image as mpimg
import cv2
import numpy as np



frm=plt.figure()
img = mpimg.imread("lineas.jpg")
cols=img.shape[1]
rows=img.shape[0] 
horizontal_size=cols//10
vertical_size=rows//10
a=frm.add_subplot(2,3,1)
imgplot = plt.imshow(img)
a=frm.add_subplot(2,3,2)
cr=cv2.getStructuringElement(cv2.MORPH_RECT,(horizontal_size,3))
imop=cv2.morphologyEx(img,cv2.MORPH_OPEN,cr)
imgplot = plt.imshow(imop)
a=frm.add_subplot(2,3,3)
cr=cv2.getStructuringElement(cv2.MORPH_RECT,(3,vertical_size))
imop=cv2.morphologyEx(img,cv2.MORPH_OPEN,cr)
imgplot = plt.imshow(imop)

##Mostrar la imagen##
plt.show()