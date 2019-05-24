﻿Feature: Surveys


Scenario: 1 Configuración completa exitosa de encuestas
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Encuestas general
	And DIligencio nivel de satisfacción global
	And Selecciono tiempo de medición
	And Diligencio y selecciono usuario monitor
	And Diligencio y selecciono correo de monitor externo
	And Doy click en Guardar configuración general de encuestas
	Then Se muestra mensaje indicando que se actualizo correctamente
	And Cierro Sesión en la aplicación
