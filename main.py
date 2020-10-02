import pygame
import time
#制作一个主界面
def main():
    #设置蛇的节数
    num=90
    screen=pygame.display.set_mode((2000,1000))
    background=pygame.image.load('./images/background.jpg')
    pygame.display.set_caption('slither')
    MySnakeH=SHead(screen,1000,500)
    namelist=[]
    for item in range(1000):
        namelist.append(item)
    for i in range(num):
        namelist[i] = SBody(screen, 1000 - i * 30, 500)
    while True:
        screen.blit(background,(0,0))
        MySnakeH.display()
        MySnakeH.move()
        #跟着上一节蛇身的蛇身
        for i in range(3,num):
            namelist[i].Bdisplay()
            namelist[i].BMove(namelist[i-1])
        #跟着蛇头那一节
        namelist[1].Bdisplay()
        namelist[1].Hmove()
        #跟着第一节蛇身的那一节蛇身
        namelist[2].Bdisplay()
        namelist[2].BMove(namelist[1])
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
        global Hx,Hy
        Hx=self.x
        Hy=self.y
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
# 创建一个蛇身类,开始尝试一节身体跟着一节身体走
class SBody(SBase):
    # 跟着蛇头那一节
    def Hmove(self):
        x1=Hx
        y1=Hy
        a = x1 - self.x
        b = y1 - self.y
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
    # 跟着前一节的蛇身
    def BMove(self,last):
        x1=last.x
        y1=last.y
        a = x1 - self.x
        b = y1 - self.y
        if a >= 0 and b > 0:
            c = b / (a + b)
            d = a / (a + b)
            self.x += 10 * d
            self.y += 10 * c
        elif a < 0 and b >= 0:
            c = b / (b - a)
            d = -a / (b - a)
            self.x -= 10 * d
            self.y += 10 * c
        elif a <= 0 and b < 0:
            c = -b / (-b - a)
            d = -a / (-b - a)
            self.x -= 10 * d
            self.y -= 10 * c
        elif a > 0 and b <= 0:
            c = -b / (a - b)
            d = a / (a - b)
            self.x += 10 * d
            self.y -= 10 * c
        else:
            pass



    def Bdisplay(self):
        self.screen.blit(self.image, (self.x, self.y))
main()
