import time
data = {
    "fruits":["apple","banana","orange","grape"],
    "games":["CODMW","Roblox","TF2"],
    "schools":["UP","DLSU","OLFU","SNSM","MSHS"],
}
for school in data["games"]:
    for char in school:
        print(char, end="", flush=True)
        time.sleep(0.4)
    print()

