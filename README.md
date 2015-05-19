# TreeSurvey
[Trees](http://en.wikipedia.org/wiki/Tree_(data_structure)) are one of the most widely used type of [ADTs](http://en.wikipedia.org/wiki/Abstract_data_type). In this project, we will review the most used trees. The goal of this project is to be a portal for any programmer who needs to find right type of tree for a particular need.

We will mainly focus on trees for indexing at the early stage of the project. We will collect original academic papers. We will collect and write sample codes and test codes for any tree we reviewed. We will also make comparisons of trees we collected.

# Tree as a dynamic index
Abstractly, a dynamic index gives us an abstract search function of key:Tkey->items:List<Titem>. We know that by employing a tree, as we go down to a subtree, the problem is divided into a simpler subproblem. As a matter of fact, we will use a recursive helper function of tree:Ttree<Tkey,Titem>->key:Tkey->subtree:Ttree<Tkey,Titem> to implement this dived and conquer search mechanism.

Search in a tree and traversal of a tree are meant to be easy. The hard part of managing a dynamic index using a tree is to find a proper balancing mechanism that right and efficient for certain kind of indexing task.
