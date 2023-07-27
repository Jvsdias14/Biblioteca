from classescobrinha import Cobra
import pygame

class Application():
    def __init__(self):
        pygame.init()
        self.tela = pygame.display.set_mode((600,450))
        self.player_pos = pygame.Vector2(self.tela.get_width() / 2, self.tela.get_height() / 2)
        self.crobation()
        pygame.display.flip()
        running = True

        while running:
            for event in pygame.event.get():
                if event.type == pygame.QUIT:
                    running = False
                    
    def crobation(self):
        pygame.draw.circle(self.tela, "midnightblue", self.player_pos , 80)
        
        

Application()
