# DrawingTool

Laborator 7 – Composite + Bridge + Proxy

## Descriere

Aplicatia implementeaza un sistem grafic de desenare folosind pattern-urile:

- Composite
- Bridge
- Proxy

Formele grafice pot fi desenate, mutate, scalate si grupate in scene compuse.

---

# Pattern-uri implementate

## Composite

Pattern-ul Composite permite tratarea uniforma a formelor simple si a grupurilor de forme.

Clase:
- Line
- Circle
- Rectangle
- Ellipse
- Picture

Picture contine o colectie de obiecte IShape si propaga operatiile:
- Draw()
- Move()
- Scale()
- GetBoundingBox()

---

## Bridge

Pattern-ul Bridge separa modelul formelor de modul de randare.

Interfata:
- ICanvas

Implementari:
- ConsoleCanvas
- SvgCanvas

Formele nu cunosc modul de desenare si folosesc doar interfata ICanvas.

SvgCanvas genereaza un fisier SVG exportabil.

---

## Proxy

Pattern-ul Proxy controleaza accesul la obiectele grafice.

Clasa:
- ReadOnlyShapeProxy

Permite:
- Draw()

Blocheaza:
- Move()
- Scale()

La modificare se arunca:
```text
InvalidOperationException
Exemplu de scena

Aplicatia construieste o scena compusa din:

Line
Circle
Rectangle
Ellipse

Scena este:

desenata
mutata
scalata
exportata SVG
Teste

Sunt implementate teste unitare pentru:

Composite
Bridge
Proxy

Toate testele trec cu succes:

7 Passed
Tehnologii utilizate
C#
.NET 10
MSTest
SVG
