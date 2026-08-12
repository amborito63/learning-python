import random

num1 = input("First Number: ")
num2 = input("Second Number: ")

op = input("Operation: ");
if op == "+":
    print (f"{num1} + {num2} = {float(num1) + float(num2)}")
    if num1 == "2" and num2 == "2":
        if random.random() < 0.10:
            print("hmm, depende kung 3 yan kasi kung 3 yan edi 5")
elif op == "-":
    print(f"{num1} - {num2} = {float(num1) - float(num2)}")
elif op == "*":
    print(f"{num1} * {num2} = {float(num1) * float(num2)}")
elif op == "/":
    try: print(f"{num1} / {num2} = {float(num1) / float(num2)}")
    except ZeroDivisionError:
        print("You cannot divide by zero.")
else:
    print("Invalid operation.")
