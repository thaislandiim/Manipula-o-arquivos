rodar = open("numero.txt", "w")
for number in range(0,101):
  rodar.write(str(number) + "\n") #no for esta como int e tem que ser string
rodar.close()

rodar = open("numero.txt", "r")
for line in rodar:
  number = int(line) #atribuindo para number ser igual a line e passando ela p int pq ela estava como string
  if number % 2 == 0:
    print(number)
rodar.close()