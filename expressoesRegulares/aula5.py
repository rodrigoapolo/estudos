# Meta caracteres: ^ $ ( )
# (Luiz|Otavio)+ 
import re

texto = '''
<p>Frase 1</p> <p>Eita</p> <p>Qualquer frase</p> <div></div>
'''

print(re.findall(r'<[dpiv]{1,3}>.*?<\/[dpvi]{1,3}>', texto))



