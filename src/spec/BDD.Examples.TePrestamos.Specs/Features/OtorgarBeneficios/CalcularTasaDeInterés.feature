Característica: Calculo de tasa de interés
	Para apoyar el desarrollo económico de comunidades de escasos recursos
	Como un directivo del banco
	Yo quiero conceder una tasa de interés más baja a personas desfavorecidas

Escenario: Cliente desplazado por la violencia
	Dado que el cliente es desplazado por la violencia
	Cuando se calcule su interés
	Entonces deberían descontársele 5 puntos
		Y el total no debería exceder 10

Escenario: Cliente madre cabeza de familia
	Dado que el cliente es madre cabeza de hogar
	Cuando se calcule su interés
	Entonces deberían descontársele 4 puntos
		Y el total no debería exceder 10

Escenario: No aplican beneficios
	Dado que el cliente no es desplazado ni madre cabeza de hogar
	Cuando se calcule su interés
	Entonces no deberían realizarse descuentos a su tasa de interés
