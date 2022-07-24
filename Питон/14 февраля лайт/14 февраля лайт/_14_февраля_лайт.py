import time
from turtle import *

pen = Turtle()
pen.color('red')
bgcolor('black')

def curve():
    for i in range(200):
        pen.right(1)
        pen.forward(1)

def draw_heart():
    pen.fillcolor('red')
    pen.begin_fill()
    pen.left(140)
    pen.forward(113)
    curve()
    pen.left(120)
    curve()
    pen.forward(112)
    pen.end_fill()


def draw_text():
    pen.up()
    pen.setpos(-50, 90)
    pen.down()
    pen.color('white')
    pen.up()
    pen.setpos(-70, 70)
    pen.down()
    time.sleep(1)  
    

draw_heart()
draw_text()
pen.ht()
done()
