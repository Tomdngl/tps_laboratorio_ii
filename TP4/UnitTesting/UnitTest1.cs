using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LanzamientoJugar_RojoTieneMasAciertosQueVerde_RetornaTrueGanadorRojoY500Puntos()
        {
            //Arrange
            Profesor profesor = new Profesor("Nombre", "Apellido", "111111111", 111, Materia.CienciasNaturales);
            Alumno alumno1 = new Alumno("Nombre", "Apellido", "111111111", 111111, Curso.Cuarto_A, Equipo.Rojo);
            Alumno alumno2 = new Alumno("Nombre", "Apellido", "111111111", 111111, Curso.Cuarto_A, Equipo.Verde);
            Lanzamiento lanzamiento = new Lanzamiento(50, profesor, "lanzamiento1");
            lanzamiento.Agregar(alumno1);
            lanzamiento.Agregar(alumno2);

            //Act
            bool isOk = lanzamiento.Jugar(10, 9, 50);

            //Assert
            Assert.AreEqual(isOk, true);
            Assert.AreEqual(Equipo.Rojo, lanzamiento.Ganador);
            Assert.AreEqual(lanzamiento.Puntos, 500);
        }

        [TestMethod]
        public void CarreraJugar_RojoGanaCon2Participantes_RetornaPuntosPorParticipanteGanadorYGanadorRojo()
        {
            //Arrange
            Profesor profesor = new Profesor("Nombre", "Apellido", "111111111", 111, Materia.CienciasNaturales);
            Carrera carrera = new Carrera(50, profesor, "carrera1");
            Alumno alumnorojo1 = new Alumno("Nombre", "Apellido", "111111111", 111111, Curso.Cuarto_A, Equipo.Rojo);
            Alumno alumnorojo2 = new Alumno("Nombre", "Apellido", "111111111", 111111, Curso.Cuarto_A, Equipo.Rojo);
            Alumno alumnoverde1 = new Alumno("Nombre", "Apellido", "111111111", 111111, Curso.Cuarto_A, Equipo.Verde);
            Alumno alumnoverde2 = new Alumno("Nombre", "Apellido", "111111111", 111111, Curso.Cuarto_A, Equipo.Verde);
            carrera.Agregar(alumnorojo1);
            carrera.Agregar(alumnorojo2);
            carrera.Agregar(alumnoverde1);
            carrera.Agregar(alumnoverde2);

            //Act
            bool isOk = carrera.Jugar(Equipo.Rojo, 50);

            //Assert
            Assert.AreEqual(isOk, true);
            Assert.AreEqual(Equipo.Rojo, carrera.Ganador);
            Assert.AreEqual(100, carrera.Puntos);
        }
    }
}
