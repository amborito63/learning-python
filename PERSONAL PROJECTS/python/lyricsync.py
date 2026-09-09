import time
lyrics_tuple = [
    ("There was something about you", 0.07),
    ("That now, I can't remember", 0.095),
    ("It's the same damn thing", 0.1),
    ("That made my heart surrender", 0.085),
    ("And I'll miss you on the train", 0.075),
    ("I'll miss you in the mornin'", 0.085),
    ("I never know what to think about..", 0.1),
    ("I think about you.", 0.14),
]
for line, delay in lyrics_tuple:
    for char in line:
        print(char, end="", flush=True)
        time.sleep(delay)
    print()
    time.sleep(delay)