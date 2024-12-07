// Assignment #: 10
// Full Name: Yeonhee Do
// Student ID: 2211198
// Version #: 2
// Submission Date: 2023-12-16

using System;
using System.Collections.Generic;

namespace MazeGame_Yeonhee.Classes.Pathfinding
{
    public class AStar
    {
        public static List<Node> FindPath(Node startNode, Node goalNode)
        {
            List<Node> path = new List<Node>();

            SortedNodeList openedNodes = new SortedNodeList();
            SortedNodeList closedNodes = new SortedNodeList();

            openedNodes.Add(startNode);

            // While openedNodes is not empty
            while (openedNodes.Count > 0)
            {
                // Get a node from the openNodes
                Node currentNode = openedNodes.TakeOutNode();

                // If currentNode is same as goalNode,
                if (currentNode.IsMatch(goalNode))
                {
                    // Set the previousNode of the goalNode
                    goalNode.PreviousNode = currentNode.PreviousNode;

                    // Finish finding a path
                    break;
                }

                // Get nodes that can come after currentNode
                List<Node> possibleNextNodes = currentNode.GetPossibleNextNodes();

                foreach (Node possibleNode in possibleNextNodes)
                {
                    int oIndex = openedNodes.GetIndexOf(possibleNode);

                    if (oIndex < 0)
                    {
                        int cIndex = closedNodes.GetIndexOf(possibleNode);

                        if (cIndex < 0)
                        {
                            // If the possible node is not opened nor closed, add it into the openNodes
                            openedNodes.Add(possibleNode);
                        }
                    }
                }

                // Close the currentNode
                closedNodes.Add(currentNode);
            }

            // Get pathNodes from goalNode to startNode following its previous Node
            Node pathNode = goalNode;

            while (pathNode != null)
            {
                path.Insert(0, pathNode);
                pathNode = pathNode.PreviousNode;
            }

            return path;
        }
    }
}
