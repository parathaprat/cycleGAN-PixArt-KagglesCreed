# Project Title : Pixel Art Generation And GameDev On Pixelated Images
#### Pixel arts lets us express more in less, helps in creating light weight and beautiful applications. CycleGans are used to convert realistic images to pixel art.
#### A cycleGAN was designed and optimally trained with appropriate parameters to convert images to pixelated formats. These Pixelated Images were then used to create a 2D platformer game in Unity- Kaggle's Creed.


## Datasets
#### Label A :

dataset 1: https://www.kaggle.com/lijiyu/imagenet

dataset 2: https://www.kaggle.com/sarthak4u/aimages

#### Label B:

dataset 1: https://www.kaggle.com/sarthak4u/bimages

dataset 2: https://drive.google.com/file/d/1ko4sGkiIppFH9248_7LVYiyHpzU6OFQp/view?usp=sharing



## Parametrs used for optimal results-  

##### Datasets :

Train :

Label A : https://www.kaggle.com/lijiyu/imagenet

Label B : https://drive.google.com/file/d/1ko4sGkiIppFH9248_7LVYiyHpzU6OFQp/view?usp=sharing

##### Epochs  : 10

##### Lambda (learning rate)  : 2e-4

##### Batch Size : 10 for both the labels (though can be kept different)

## Some Outputs
![Outputs](Outputs/1.png)
![Outputs](Outputs/8.png)
![Outputs](Outputs/10.png)
![Outputs](Outputs/18.png)
![Outputs](Outputs/32.png)


Game Assets were run through this optimized cycleGAN, and these pixelated assets were then used to create Kaggle's Creed. <br />

## Kaggle's Creed

Kaggle's Creed is a 2D platformer game built in Unity for PC. Players spawn in a flat pixelated world as one of the 2 avatars available to pick on the main menu. Three distinctive monsters are spawned on either side of the map and approach the player at varying speeds. The objective of the game is to avoid contact with the monsters by jumping over them. <br />

Play on Mac- https://drive.google.com/file/d/1tnFIng8ktjO8XBW5__ai_QdNjBdncR-2/view?usp=sharing <br />
Play on Windows- https://drive.google.com/file/d/1I3mS8Fjd-0BSQTaPEP0DoQQhXd0JdY16/view?usp=sharing <br />

<img width="1440" alt="main menu" src="https://user-images.githubusercontent.com/84290855/152471062-880b2f5f-c4ba-4f78-bfd5-ecc270e6bfe6.png">

<img width="1440" alt="ingame" src="https://user-images.githubusercontent.com/84290855/152471097-01ef2791-aa3a-48b8-8d53-d117bd2f27d8.png">




