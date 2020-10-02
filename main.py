import pygame
import time
#制作一个主界面
def main():
    #设置蛇的节数
    num=9
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
# 重写移动方式 注:此处为玩家蛇
    def move(self):
        coordinate = pygame.mouse.get_pos()
        x1=coordinate[0]
        y1=coordinate[1]
        a=x1-self.x
        b=y1-self.y
        if a>=0 and b>0:
            c=b/(a+b)
            d=a/(a+b)
            self.x+=10*d
            self.y+=10*c
        elif a<0 and b>=0:
            c=b/(b-a)
            d=-a/(b-a)
            self.x -= 10 * d
            self.y += 10 * c
        elif a<=0 and b<0:
            c=-b/(-b-a)
            d=-a/(-b-a)
            self.x -= 10 * d
            self.y -= 10 * c
        elif a>0 and b<=0:
            c=-b/(a-b)
            d=a/(a-b)
            self.x += 10 * d
            self.y -= 10 * c
        else:
            pass



    def display(self):
        self.screen.blit(self.image,(self.x,self.y))
# 创建一个蛇身类
class SBody(SHead):
    def Bdisplay(self):
        self.x+=5
        self.screen.blit(self.image, (self.x, self.y))
main()
