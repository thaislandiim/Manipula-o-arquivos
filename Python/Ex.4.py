dadoLista = []
#Lendo o arquivo e carregando em memória 
arquivo = open("lista.txt", "r")
for linha in arquivo:
  linha = linha.replace("\n","").replace(" ","")
  cidadeDentista = linha.split(",")
  dadoLista.append(cidadeDentista)
arquivo.close()

#Lendo do usuário e comparando com a lista em memória
sair = 0

while sair == 0:
  dado = {'dentistas': None, 'cidade': None} 
  dado['dentistas'] = input("Insira a quantidade de dentistas: ")
  dado['cidade'] = input("Insira o nome da cidade: ")
  flag = 0
  for d in dadoLista:
    if dado['cidade'] == d[1]:
      d[0] = dado['dentistas'] 
      flag = 1
  if flag == 0:
    dadoLista.append([dado['dentistas'], dado['cidade']])
  sair = int(input("Você deseja sair? Digite 0 para CONTINUAR. Digite 1 para SAIR: "))

print(dadoLista)

#Escrevendo os dados novamente em arquivo (substuindo "w")
arquivo = open("lista.txt", "w")
for linha in dadoLista:
  arquivo.write(str(linha[0]) + ", " + str(linha[1]) + "\n")
arquivo.close()