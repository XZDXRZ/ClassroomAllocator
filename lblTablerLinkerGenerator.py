# A programme to generate 90 lines of code for MasterForm.vb
# @author: XZDXRZ

lstPeriod = [
    "TUTORIAL",
    "PERIOD1",
    "PERIOD2",
    "RECESS",
    "PERIOD3",
    "PERIOD4",
    "LUNCH",
    "PERIOD5",
    "PERIOD6"
]

lstLblPeriod = [
    "Tutorial",
    "Period1",
    "Period2",
    "Recess",
    "Period3",
    "Period4",
    "Lunch",
    "Period5",
    "Period6"
]

lstRoom = [
    "S01",
    "S02",
    "S03",
    "S04",
    "S05",
    "S06",
    "S07",
    "S08",
    "S09",
    "S10"
]

str1 = "lblTableLinker(Period."
# enumPeriod
str2 = ", Room."
# enumRoom
str3 = ") = lbl"
# enumLblPeriod
# enumRoom
str4 = "\n"

with open("./lblTableLinkerCode.txt", mode="w") as file:
    for periodIndex in range(1, len(lstPeriod) + 1):
        for roomIndex in range(1, len(lstRoom) + 1):
            file.write(
                str1+
                lstPeriod[periodIndex - 1]+
                str2+
                lstRoom[roomIndex - 1]+
                str3+
                lstLblPeriod[periodIndex - 1]+
                lstRoom[roomIndex - 1]+
                str4)
