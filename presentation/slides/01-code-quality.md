## Warum ist Code Qualität wichtig?

O-Töne von Nicht-Entwicklern:

- "Programmieren ist hauptsächlich Implementierung von neuen Features" <!-- .element: class="fragment" data-fragment-index="0" -->
- "Der Code kompiliert, macht was er soll, somit ist alles in Ordnung" <!-- .element: class="fragment" data-fragment-index="1" -->
- "Fachbereiche bezahlen für Features, nicht für "schönen" Code" <!-- .element: class="fragment" data-fragment-index="2" -->

---

...what other people think we do...

<div>
<iframe src="https://giphy.com/embed/QNFhOolVeCzPQ2Mx85" width="480" height="270" frameBorder="0" class="giphy-embed" allowFullScreen></iframe><p><a href="https://giphy.com/gifs/checkmatedigital-code-coding-monkey-QNFhOolVeCzPQ2Mx85/fullscreen"></a></p>
</div>

----

...what we actually do...
<iframe src="https://giphy.com/embed/WoWm8YzFQJg5i" width="480" height="351" frameBorder="0" class="giphy-embed" allowFullScreen></iframe><p><a href="https://giphy.com/gifs/cartoons-comics-sea-reading-WoWm8YzFQJg5i"></a></p>

---

- Das Verhältnis von Code lesen zu schreiben ist 10:1 (!)
- Die meiste Zeit wird existierender Code gelesen und evtl. erweitert <!-- .element: class="fragment" data-fragment-index="1" -->
  - Wartung ist die längste Phase des Produktlebenszyklus <!-- .element: class="fragment" data-fragment-index="1" -->
  - Trifft auch zu, wenn ein komplett neues Modul geschrieben wird <!-- .element: class="fragment" data-fragment-index="1" -->
- Du bist nicht allein! <!-- .element: class="fragment" data-fragment-index="2" -->
  - Entwickler arbeiten in Teams <!-- .element: class="fragment" data-fragment-index="2" -->

---

- Sinkende Produktivität über die Zeit bei unordentlichem Code

![productivity-over-time](images/productivity-over-time.png)

<cite class="small">Quelle: Clean Code - A Handbook of Agile Software Craftsmanship (R.C. Martin)</cite>

---

## Probleme mit chaotischem Code

- Schwer zu verstehen <!-- .element: class="fragment" data-fragment-index="0" -->
  - und noch viel schwerer zu erweitern <!-- .element: class="fragment" data-fragment-index="0" -->
- Neue Fehler schleichen sich bei Änderungen leichter ein <!-- .element: class="fragment" data-fragment-index="1" -->
- Sinkende Produktivität <!-- .element: class="fragment" data-fragment-index="2" -->
- Das Chaos wächst, wenn man nicht mit Umsicht handelt! <!-- .element: class="fragment" data-fragment-index="3" -->

---
<!-- .slide: data-background="images/broken-window.jpg" data-background-size="cover"  data-state="dimmed" -->

## Broken window theory

> A building with broken windows looks like nobody cares about it. So other people stop caring. They allow more windows to become broken. Eventually they actively break them.<!-- .element: class="fragment" data-fragment-index="1" -->

<cite>Dave Thomas and Andy Hunt</cite><!-- .element: class="fragment" data-fragment-index="1" -->

<cite>(Ursprünglich von den Sozialforscher James Q. Wilson and George L. Kelling, März 1982)</cite><!-- .element: class="fragment small" data-fragment-index="1" -->

---

## Definitionen von Clean Code

----

> Clean code reads like well-written prose. Clean code never obscures the designer's intent but rather is full of crisp abstractions and straightforward lines of control.

<cite>Grady Booch</cite>

----

> Clean code can be read, and enhanced by a developer other than its original author.

<cite>Dave Thomas</cite>

----

> Clean code always looks like it was written by someone who cares.

<cite>Michael Feathers</cite>

----

> Always code as if the guy who ends up maintaining your code will be a violent psychopath who knows where you live.

<cite>Martin Golding</cite>

---

## Wann ist Code clean, sauber, aufgeräumt?

- Einfach und direkt <!-- .element: class="fragment" data-fragment-index="0" -->
- Aussagekräftige Namen <!-- .element: class="fragment" data-fragment-index="1" -->
- Tut immer das, was man erwartet <!-- .element: class="fragment" data-fragment-index="2" -->
- Einfach zu lesen und erweiterbar <!-- .element: class="fragment" data-fragment-index="3" -->
- ... <!-- .element: class="fragment" data-fragment-index="3" -->

- "Clean code does one thing well" <!-- .element: class="fragment" data-fragment-index="4" -->
