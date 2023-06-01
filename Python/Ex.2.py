def facaMedia(n1, n2, n3, n4):
  media = (n1 + n2 + n3 + n4) / 4
  return media
  
def aprovacao(media):
  if media > 5:
    print("Aprovado")
  else:
    print("Reprovado")

mediaAlunos = open("aprovar.txt", "w")
nome1 = input("Insira o nome do aluno: ")
n1 = int(input("Insira sua 1° nota: "))
n2 = int(input("Insira sua 2° nota: "))
n3 = int(input("Insira sua 3° nota: "))
n4 = int(input("Insira sua 4° nota: "))

media = facaMedia(n1, n2, n3, n4)
aprovacao(media)
mediaAlunos.close()