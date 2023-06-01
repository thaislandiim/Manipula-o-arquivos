funcionarios = [] #lista

for n in range(0,5):
  funcionarios.append({'nome': None, 'idade': None, 'cidNasc': None}) #registro

for n in range(0,5):
  funcionarios[n]['nome'] = input("Insira o nome do funcionário: ")
  funcionarios[n]['idade'] = int(input("Insira a idade do funcionário: "))
  funcionarios[n]['cidNasc'] = input("Insira a cidade de nascimento do funcionário: ")

arquivo = open("funcionario.txt", "w")
for n in range(0,5):
  arquivo.write(str(funcionarios[n]['nome']) + "; ")
  arquivo.write(str(funcionarios[n]['idade']) + "; ")
  arquivo.write(str(funcionarios[n]['cidNasc']) + "\n")
arquivo.close()