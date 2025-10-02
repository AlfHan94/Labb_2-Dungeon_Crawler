using Labb_2_Dungeon_Crawler;

var wall = new Wall(10, 4);
wall.Draw();

var rat = new Rat(5, 3);
rat.Draw();

var snake = new Snake(6, 10);
snake.Draw();

Console.ReadKey();