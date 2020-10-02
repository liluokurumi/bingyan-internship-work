import pygame
import time
#制作一个主界面
def main():
    #设置蛇的节数
    num=10
    screen=pygame.display.set_mode((2000,1000))
    background=pygame.image.load('./images/background.jpg')
    pygame.display.set_caption('slither')
    MySnakeH=SHead(screen,1000,500)
    namelist=[]
    for item in range(1000):
        namelist.append(item)
    for i in range(num):
        namelist[i] = SBody(screen, 1000 - i * 20, 500)
    while True:
        screen.blit(background,(0,0))
        MySnakeH.display()
        MySnakeH.move()
        for i in range(num):
            namelist[i].Bdisplay()
        pygame.display.update()
        for event in pygame.event.get():
            if event.type==pygame.QUIT:
                print('游戏结束')
                pygame.quit()
                break
#创建一个蛇基类
class SBase():
    def __init__(self,screen,x,y,):
        # 创建一个中心圆
        self.x=x
        self.y=y
        self.screen=screen
        radius=25
        width=radius
        self.position=self.x,self.y
        self.point=(self.position)
        color=0,255,0
        self.a=pygame.draw.circle(screen,color,self.position,radius,width)
        self.image=pygame.image.load('./images/SnakeBase.png')
# 创建一个蛇头类
class SHead(SBase):
# 先让蛇头往左动试试
    def move(self):
        self.x+=5
    def display(self):
        self.screen.blit(self.image,(self.x,self.y))




# 创建一个蛇身类
class SBody(SHead):
    def Bdisplay(self):
        self.x+=5
        self.screen.blit(self.image, (self.x, self.y))
#写一个函数创建新对象使身体变长
main()
