using System;

namespace CentroEducativoVR
{
    public class AvatarInstructor : ObjetoVR
    {
        public AvatarInstructor() : base("Avatar Instructor") { }

        public override void Usar()
        {
            Console.WriteLine("[Avatar] Enseñando a los estudiantes");
        }
    }
}