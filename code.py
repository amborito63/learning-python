import time

user = input("Enter your name: ")

if user == "admin":
    print("Welcome, Developer! Thank you for your service!")
else:
    print (f"Hello, {user}! Welcome to the storage unit!")


def delayed_print(text, delay=0.5):
    for char in text:
        print (char, end="", flush=True)
        time.sleep(delay)
    print()

data = {
    "fruits":["apple","banana","orange","grape"],
    "games":["CODMW","Roblox","TF2"],
    "schools":["UP","DLSU","OLFU","SNSM","MSHS"],
}
shelf_choice = input("Which shelf? (fruits, games, schools): ")
if shelf_choice == "schools":
    for school in data["games"]:
      delayed_print(school, 0.05) 

elif shelf_choice == "fruits":
    for fruit in data["fruits"]:
        delayed_print(fruit, 0.05)

elif shelf_choice == "games":
    for games in data["games"]:
        delayed_print(games, 0.05)

elif shelf_choice == "secret060108":
    delayed_print("Access granted! Welcome to the Developers birthday room!", 0.05)

else:
    delayed_print("Invalid shelf choice. Please try again.", 0.05)
    
