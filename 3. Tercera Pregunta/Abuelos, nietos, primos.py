# -*- coding: utf-8 -*-
"""
Spyder Editor

This is a temporary script file.
"""
from pyswip import Prolog
prolog = Prolog()

prolog.assertz("padre(ramiro, rocio)")
prolog.assertz("padre(ramiro, miguel)")

prolog.assertz("abuelo(felipe, rocio)")
prolog.assertz("abuelo(felipe, miguel)")

prolog.assertz("primo(gabriel, miguel)")
prolog.assertz("primo(gabriel, rocio)")

for element in prolog.query("padre(X,Y)"):
    print(element["X"], " es el padre de  ", element("Y"))
    
for element in prolog.query("padre(X,Y)"):
    print(element["X"], " es el abuelo de  ", element("Y"))
    
for element in prolog.query("padre(X,Y)"):
    print(element["X"], " es el primo de  ", element("Y"))
