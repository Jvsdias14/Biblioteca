from classescobrinha import Cobra
import pygame
import sys
from time import sleep
import random

class Application():
    def __init__(self):
        pygame.init()
        self.tela = pygame.display.set_mode((600,450))
        self.player_pos = pygame.Vector2(self.tela.get_width() / 2, self.tela.get_height() / 2)
        self.crobation()
        pygame.display.flip()
        running = True
        self.command = ""
        self.cria_maca()  
         
        while running:
            for event in pygame.event.get():
                if event.type == pygame.QUIT:
                    running = False
                if event.type == pygame.KEYDOWN:
                    if event.key == pygame.K_UP:
                        self.command = "UP" 
                    if event.key == pygame.K_DOWN:      
                        self.command = "DOWN"
                    if event.key == pygame.K_LEFT:
                        self.command = "LEFT"
                    if event.key == pygame.K_RIGHT:
                        self.command = "RIGHT"
                        
            if self.command == "UP":
                self.player_pos[1] -= 35
            if self.command == "DOWN":
                self.player_pos[1] += 35
            if self.command == "LEFT":
                self.player_pos[0] -= 35
            if self.command == "RIGHT":
                self.player_pos[0] += 35
                          
            self.crobation() 
            self.pega_maca()      
   
    def crobation(self):   
        sleep(0.2)
        self.tela.fill("black")
        pygame.draw.rect(self.tela, "green", [self.player_pos[0] - 25,self.player_pos[1] -25,50,50],0,7)
        pygame.display.update()
        
    def pega_maca(self):
        pygame.draw.rect(self.tela, "red", [0 + self.posx, 0 + self.posy,25,25],0,7)
        pygame.display.update()
        
    def cria_maca(self):
        sorte1 = random.randint(1,9)
        sorte2 = random.randint(1,9)
        
        self.posx = 50 * sorte1
        self.posy = 50 * sorte2
                    
            
Application()
