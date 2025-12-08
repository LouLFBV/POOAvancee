# Gestionnaire de quête  
🎮 Mini système de quêtes développé en **C#** avec **Avalonia UI**, basé sur les principes avancés de la **programmation orientée objet (POO)**.

---

## 🎯 Objectif du projet  

Ce projet a pour but de créer un **mini gestionnaire de quêtes interactif**, permettant à un joueur de :

- Choisir des quêtes parmi un lot proposé
- Gagner de l’expérience (XP) et de l’or
- Obtenir différentes récompenses (pomme, banane, XP, or)
- Consulter :
  - Son journal de quêtes
  - Ses statistiques
  - Ses récompenses
- Affronter un **boss final**
- Recommencer une partie après une victoire ou une défaite

Le projet existe sous deux formes :
- ✅ Version **Console**
- ✅ Version **Graphique (Avalonia UI)**

---

## 🧠 Concepts de Programmation Utilisés  

- **Encapsulation**
- **Héritage**
- **Polymorphisme**
- **Abstraction**
- **Listes et collections**
- **Gestion des événements**
- **Enums**
- **Séparation logique (backend / interface graphique)**

---

## 🗂️ Structure du projet  

```
/SystemeDeQueteAvalonia
│
├── Personnage.cs
├── MainWindow.axaml
├── MainWindow.axaml.cs → Interface graphique
├── App.axaml
├── Program.cs
├── /Recompenses
    ├── Evenement.cs
    ├── Recompense.cs
    ├── Banane.cs
    ├── Pomme.cs
    ├── Or.cs
    ├── Xp.cs
    ├── Importance.cs
    └──TypeRecompense.cs
└── /Quetes
    ├── Quete.cs
    ├── Collecte.cs
    ├── Exploration.cs
    └── Combat.cs
```


---

## 🕹️ Fonctionnalités

- ✅ Sélection de 3 quêtes à la fois
- ✅ Avancée même en cas d’échec
- ✅ Système de récompenses dynamique
- ✅ Gestion du journal de quêtes
- ✅ Gestion des statistiques (XP / Or)
- ✅ Combat contre un boss final
- ✅ Réinitialisation automatique de la partie
- ✅ Interface graphique interactive (Avalonia)

---

## 🖥️ Technologies utilisées  

- ✅ **Langage :** C#
- ✅ **Framework UI :** Avalonia
- ✅ **Paradigme :** Programmation Orientée Objet (POO)
- ✅ **IDE :** Visual Studio Code/2022

---

## ✍️ Convention de nommage dans la production du projet :

| Élément         | Convention     | Exemple           |
|-----------------|----------------|-------------------|
| Classe          | PascalCase     | `PlayerManager`  |
| Interface       | I + PascalCase | `IRepository`    |
| Méthode         | PascalCase     | `StartGame()`    |
| Propriété       | PascalCase     | `HealthPoints`   |
| Variable locale | camelCase      | `playerScore`    |
| Paramètre       | camelCase      | `userName`       |
| Champ privé     | _camelCase     | `_timer`         |
| Constante       | PascalCase     | `MaxSpeed`       |
| Enum            | PascalCase     | `ColorType`      |
| Valeur d’enum   | PascalCase     | `Red`, `Blue`    |

---

## 🚀 Lancement du projet  

1. Ouvrir la solution dans **Visual Studio Code/2022**
2. Définir le projet **SystemeDeQueteAvalonia** comme projet de démarrage
3. Lancer le programme (`F5`)
4. Profiter de l’interface graphique 🎉

---

## 👥 Collaborateurs  

- **Lou LEFEBVRE**
- **Maël CAETANO**
- **Hugo CABANES**
- **Yarkin ONER**

---

## ✅ État du projet  

✅ Fonctionnel  
✅ Interface graphique  
✅ Logique complète  
✅ Prêt pour soutenance / rendu final  

---

## 📌 Remarques  

Ce projet a été réalisé dans un objectif pédagogique afin de mettre en pratique :
- Les bases solides de la POO
- La gestion d’un projet structuré
- Le passage d’une logique Console vers une interface graphique

---

