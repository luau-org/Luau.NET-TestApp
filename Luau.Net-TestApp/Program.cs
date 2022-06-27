using Luau.Net;

LuauRuntime.LuaState state = new LuauRuntime.LuaState();
Console.WriteLine(state.GetStateId());
Console.WriteLine(state.Run(""));
Console.ReadLine();