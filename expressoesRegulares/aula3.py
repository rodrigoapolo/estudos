# Meta caracteres: ^ $ ( )
# * 0 ou n
# + 1 ou n
# ? 0 ou 1
# {n}
# {min, maz}
# {10,} 10 ou mais
# {,10} de zero a  10
# {10} Especificamente 10
# {5,10} de 5 a 10
# ()+ [a-zA-Z0-9]+ o quantificador é aplicado sempre a esquerda da coisa dele

import re

texto = '''
João trouxe    flores para sua amada namorada em 10 de janeiro de 1970,
Maria era o nome dela.


Foi um ano excelente na vida de joão. Teve 5 filhos, todos adultos atualmente.
maria, hoje sua esposa, ainda faz aquele café com pão de queijo nas tardes de
domingo. Também né! Sendo a boa mineira que é, nunca esquece seu famoso
pão de queijo.
Não canso de ouvir a Maria:
"Joooooooooãooooooo, o café tá prontinho aqui. Veeemm"!
'''

# print(re.findall(r'j[a-zA-Z]+ão+', texto, flags=re.I))
# print(re.findall(r'j[o]+ão+', texto, flags=re.I))
# print(re.findall(r'jo+ão+', texto, flags=re.I))
# print(re.findall(r'jo{1,}ão{1,}', texto, flags=re.I))
# print(re.findall(r'Ve{3}m{1,2}', texto, flags=re.I))
#print(re.sub(r'jo{1,}ão{1,}', 'Felipe', texto, flags=re.I))

texto2 = 'Joao ama ser amado'
print(re.findall(r'ama[do]{2}', texto2, flags=re.I))
print(re.findall(r'ama[do]*', texto2, flags=re.I))
print(re.findall(r'ama[od]{0,2}', texto2, flags=re.I))

