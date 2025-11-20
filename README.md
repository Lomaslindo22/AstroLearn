# AstroLearn

Proyecto final - Documento de análisis

Descripción del proyecto:

Problema:

El aprendizaje de conceptos de astronomía (órbitas, composición planetaria, distancias), ya que a menudo el aprender sobre esto es abstracto y se encuentran sitios muy poco interactivos, lo que genera una poca retentiva de esta información. Se identifica una necesidad clara de una herramienta o aplicativo interactivo que convierta la complejidad científica en experiencias de aprendizaje útiles y dinámicas para cada uno de sus usuarios.

Propósito del proyecto:

Desarrollar un juego o aplicación educativa e interactiva de escritorio que ayude al usuario por medio de misiones interplanetarias guiadas a aprender sobre astronomía y poner a prueba el conocimiento del usuario mediante retos específicos. El sistema se encargará de: -Tener una base de datos de usuarios. -Presentar secuencias de misiones guiadas, enfocadas en planetas o fenómenos específicos (ej. Misiones a Marte, cinturón de asteroides, constelaciones, cuerpos celestes etc). -Administrar el flujo de retos que validan el conocimiento adquirido. -Tener una base de datos de planetas, misiones y el progreso del usuario en una base de datos SQL Server. -Servir como un caso de estudio y de proyecto final de la asignatura Herramientas de programación 2, para evaluar la aplicación de Patrones de Diseño (Factory, Singleton, Repository) y principios avanzados de -Programación Orientada a Objetos (POO).

Usuarios:

Estudiantes o usuarios comunes: Usuario final que busca aprender y poner a prueba su conocimiento sobre temas astronómicos.Interactúa con la interfaz para completar diferentes retos y acceder a información
Administrador o desarrollador: Este es el encargado de mantener en constante actualización las distintas pruebas o bases de datos de la la aplicación. Tiene acceso especial en el sistema ya que puede realizar distintos CRUD para actualizar y mejorar constantemente la app.
Reglas de negocio:

-Registro Único: En el sistema no pueden haber 2 usuarios con la misma información, esto para garantizar que el registro sea único. Si el nombre ya existe en la base de datos, se debe denegar la creación de la cuenta y mostrar un mensaje de error.

-Validación de Credenciales o de campos null: En el formulario de Registro, ningún campo puede estar vacío. Se debe mostrar un mensaje de retroalimentación del error.

-Restricción de contraseña: La contraseña de un usuario debe tener una longitud mínima de 8 caracteres para ser aceptada durante el registro, esto para asegurar que sea una clave segura.

-Secuencia de Misión Obligatoria: Un usuario solo puede acceder o iniciar una misión o reto si el reto/misión anterior está marcada como Completada en su registro de progreso.

-Requisito de Misión/Reto: Una Misión/Reto completa solo se puede marcar como Completada si el usuario ha superado exitosamente el 100% del contenido del mismo, de lo contrario quedará como en progreso.

-Guardado de Progreso: El registro de la superación de una Misión/Reto debe ser guardado inmediatamente en la base de datos al finalizar exitosamente.

-Integridad de Datos astronómicos: Cada Planeta, constelación, etc en la base de datos debe tener definidos al menos tres atributos científicos obligatorios. El sistema no podrá crear un objeto (a través del Factory) si estos datos esenciales están ausentes.

-Asignación de Dificultad: Toda Misión/Reto debe estar obligatoriamente asociado a un nivel de Dificultad (ej. Básico, Intermedio, Avanzado).

-Validación de Tipos de Datos: En los formularios de ingreso de información (ej. ingreso de un puntaje o un ID), se debe validar que el dato ingresado sea del tipo esperado de lo contrario se mostrará un mensaje de error junto con la explicación de la falla.

-Feedback de Operación: Después de cualquier acción que involucre el guardado, actualización o eliminación de datos (incluso simulado con listas en este entregable), la aplicación debe mostrar un mensaje de confirmación o error al usuario.

Funcionalidades:

-El sistema no permitirá ingresar un objeto astronómico (Constelación, Planeta, Cuerpo celeste etc) si este no tiene por lo menos 3 datos científicos corroborables, esto debido a que el propósito de la aplicación es enseñar acerca de astronomía en base a distintos argumentos científicos con la mayor cantidad de datos posibles.

-Un correo electrónico solo puede estar asignado a una sola cuenta de usuario, ya que cuando un usuario en el proceso de registro intenta ingresar un correo electrónico asignado a una cuenta existente el sistema le arrojará error.