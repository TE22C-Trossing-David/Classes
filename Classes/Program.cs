using System.Runtime.Intrinsics.Arm;
using Raylib_cs;

Raylib.InitWindow(800, 800, "Pikmin game 2");
Raylib.SetTargetFPS(60);

Pikmin pikmin1 = new Pikmin();




while (!Raylib.WindowShouldClose())
{
    pikmin1.type = "typeBlue";
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.White);
    pikmin1.Draw();
    Raylib.EndDrawing();
}