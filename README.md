Tic Tac Toe - in C#
===================

My first C# programme - a simple game of tic tac toe with command line interface

Technologies:
-------------
- Mono JIT compiler version 3.8.0
- NUnit 2.6.3

Classes:
--------
- Space: basic unit of data of the game. Can be marked with 'X' or 'O'
- Grid: holds 9 spaces
- Player: can mark a space
- Game: controls game flow
- Application: runs the game

Running the application:
------------------------
```shell
$ mcs Application/*.cs
$ mono Application/application.exe 
```

Running the test suite:
-----------------------
```shell
$ mcs Application/*.cs Tests/*.cs -reference:nunit.framework.dll
$ NUNIT-CONSOLE Application/application.exe
```