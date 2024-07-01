// Program.cs
using System;
using P;
// 略
static void Main(string[] args) {
   P.Son.fun(); //this's Son
   cs.floder.fun(); //this is floder's .cs
   cs2.cs1.fun(); //cs2
   Son a = new Son();
   a.fun1(); //p is required
}

