 
# FEELit
Just feel your emotion, we are here to express them ;)

*NOTE*: This is the windows app version of the project. I'll soon upload the android version of it.

FEELit
        -A Keyboard App.
From the past decade, social networks have been a crucial part of our daily lives, which expresses us to the world. We tend to express our feelings, emotions to others through them. Now, we introduce our project FEELit, which improvise the chatting experience by taking EMOTICONS to the next level. FEELit is an added button to the keyboard, which generates the emoticons according to our mood at that point of time by pressing it :) . Now all it does in the background is, it takes the photo of the user and pulse rate of our heart and with the picture it gives a rough figure of the emotion which is later justified by the pulse rate. The pulse rate readings are sent by an external gadget attached to the user’s index finger. Let us go deep and know the working of the pulse sensor. 

## Basic Level
![](https://github.com/sannzay/FEELit/blob/master/images/1.f.png)


   This would have been a normal Keyboard app if it doesn’t contain the left most button at the bottom named “XD”. When user clicks this button, a camera opens and clicks a picture of user’s face through front camera. Later the image is analysed and the scores of the facial emotions are calculated with help of web API’s. An example of the scores of a random picture is given below.
Also built neural network models using transfer learning to detect the emotions of a facial expression.

```
"Scores": {
      "Anger": 1.0570484E-08,
      "Contempt": 1.52679547E-09,
      "Disgust": 1.60232943E-07,
      "Fear": 6.00660363E-12,
      "Happiness": 0.9999998,
      "Neutral": 9.449728E-09,
      "Sadness": 1.23025981E-08,
      "Surprise": 9.91396E-10
    }
```
              Now according to those values of scores, emoticons are shown as a suggestion to the user. In the above example, user’s surprise score is high, so the surprise emoticon is sent. Likewise, other emoticons are sent by just giving an expression.
  	 
![](https://github.com/sannzay/FEELit/blob/master/images/2.f.png) ![](https://github.com/sannzay/FEELit/blob/master/images/3.f.png)
![](https://github.com/sannzay/FEELit/blob/master/images/4.f.png)![](https://github.com/sannzay/FEELit/blob/master/images/5.f.png)  

## Higher Level
   In this “Higher Level” update, the accuracy of the user’s emotions are increased with help of user’s heart rate.  App is integrated with a wearable gadget which contains a pulse rate sensor. The gadget may also be a simple cover case containing a pulse sensor (senses the heart rate through index figure). 

![](https://github.com/sannzay/FEELit/blob/master/images/8.f.jpg)

This cover case may be replaced by smart watches or some other smart wearables. Now with these pulse readings and the previous API scores are compared and many more emotions can be identified with their combination.

If a user’s emotion score shows happiness and pulse rate is high, then his feeling is EXCITED.
If a user’s emotion score shows happiness and pulse rate is low, then his feeling is SARCASTIC.
If a user’s emotion score shows happiness and pulse rate is normal, then his feeling is HAPPY.
This may not be the only cases for these emotions. Many combinations of these scores and pulse readings lead to the variety of feelings. So by including this extra feature, the scope of the expressions and the accuracy are increased.

### Advanced Level (Not implemented yet)
   At a particular time, we intend to send an emoticon which is not in the emoticons list. For example, user wants to send his own weird expression as an emoticon, which is generally not possible. But by analysing the image through high level image processing techniques, I believe that we can spot the exact positions of eyes, mouth, chin, cheeks and instantly create an emoticon which best reflects the user’s unique expression. Which later may be saved and used in the future or add it into the user’s favourite emoticons gallery. It can later be extended to a short duration video emoji.

![](https://github.com/sannzay/FEELit/blob/master/images/9.f.jpg)                           ![](https://github.com/sannzay/FEELit/blob/master/images/10.f.jpg)
![](https://github.com/sannzay/FEELit/blob/master/images/11.f.jpg)                            ![](https://github.com/sannzay/FEELit/blob/master/images/12.f.png)

                            


