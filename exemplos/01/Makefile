
EXE = hellworld.exe

all: run

hellworld.exe: hellworld.cs
	mcs hellworld.cs

run: hellworld.exe
	mono $(EXE)

clean:
	rm $(EXE)
