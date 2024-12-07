// Assignment #: 10
// Full Name: Yeonhee Do
// Student ID: 2211198
// Version #: 2
// Submission Date: 2023-12-16

using MazeGame_Yeonhee.Classes.Entities;
using System;
using System.Collections.Generic;

namespace MazeGame_Yeonhee.Classes.Pathfinding
{
    public class Node
    {
        private static int distanceBetweenNode = 1;

        private int row; // y
        private int column; // x
        private Node previousNode;
        private Node goalNode;
        private int gCost; // startNode to currentNode(this)
        private int hCost; // currentNode(this) to goalNode
        private int fCost; // startNode to goalNode (= total Cost)

        public Node PreviousNode { get => previousNode; set => previousNode = value; }
        public int Row { get => row; set => row = value; }
        public int Column { get => column; set => column = value; }
        public int FCost { get => fCost; set => fCost = value; }

        public Node(int row, int column, Node previousNode, Node goalNode)
        {
            this.row = row;
            this.column = column;
            this.previousNode = previousNode;
            this.goalNode = goalNode;

            // Set gCost
            if (this.previousNode != null)
            {
                this.gCost = previousNode.gCost + distanceBetweenNode;
            }
            // if this is the startNode,
            else
            {
                this.gCost = 0;
            }

            // Set hCost
            this.hCost = GetHCost();
            this.fCost = gCost + hCost;
        }

        public int GetHCost()
        {
            // Get hCost using Pythagorean Triples
            if(goalNode != null)
            {
                int xDistance = this.goalNode.row - this.row;
                int yDistance = this.goalNode.column - this.column;
                return (int)Math.Sqrt((xDistance * xDistance) + (yDistance * yDistance));
            }
            else
            {
                return 0;
            }
        }

        public List<Node> GetPossibleNextNodes()
        {
            List<Node> possibleNextNodes = new List<Node>();

            // Check if the upperNode is a Wall or the previousNode
            if (!(Map.tiles[this.row - 1, this.column] is Wall))
            {
                Node upperNode = new Node(this.row - 1, this.column, this, this.goalNode);

                if (this.previousNode != null)
                {
                    // If upperNode is not the node that this came from,
                    if (!IsMatch(upperNode, this.previousNode))
                    {
                        possibleNextNodes.Add(upperNode);
                    }
                }
                // If this node is the start node (so there is no previousNode),
                else
                {
                    possibleNextNodes.Add(upperNode);
                }
            }

            // Check if the lowerNode is a Wall or the previousNode
            if (!(Map.tiles[this.row + 1, this.column] is Wall))
            {
                Node lowerNode = new Node(this.row + 1, this.column, this, this.goalNode);

                if (this.previousNode != null)
                {
                    // If lowerNode is not the node that this came from,
                    if (!IsMatch(lowerNode, this.previousNode))
                    {
                        possibleNextNodes.Add(lowerNode);
                    }
                }
                // If this node is the start node (so there is no previousNode),
                else
                {
                    possibleNextNodes.Add(lowerNode);
                }
            }

            // Check if the leftNode is a Wall or the previousNode
            if (!(Map.tiles[this.row, this.column - 1] is Wall))
            {
                Node leftNode = new Node(this.row, this.column - 1, this, this.goalNode);

                if (this.previousNode != null)
                {
                    // If leftNode is not the node that this came from,
                    if (!IsMatch(leftNode, this.previousNode))
                    {
                        possibleNextNodes.Add(leftNode);
                    }
                }
                // If this node is the start node (so there is no previousNode),
                else
                {
                    possibleNextNodes.Add(leftNode);
                }
            }

            // Check if the rightNode is a Wall or the previousNode
            if (!(Map.tiles[this.row, this.column + 1] is Wall))
            {
                Node rightNode = new Node(this.row, this.column + 1, this, this.goalNode);

                if (this.previousNode != null)
                {
                    // If rightNode is not the node that this came from,
                    if (!IsMatch(rightNode, this.previousNode))
                    {
                        possibleNextNodes.Add(rightNode);
                    }
                }
                // If this node is the start node (so there is no previousNode),
                else
                {
                    possibleNextNodes.Add(rightNode);
                }
            }
            return possibleNextNodes;
        }

        public bool IsMatch(Node node1)
        {
            // Compare this node and another node1
            return (this.row == node1.row && this.column == node1.column);
        }

        public bool IsMatch(Node node1, Node node2)
        {
            // Compare two nodes
            return (node1.row == node2.row && node1.column == node2.column);
        }

        public bool IsSameOrBetterThan(Node node)
        {
            if (node == null)
            {
                return false;
            }
            else
            {
                // If this node is better (less cost), return true
                return this.fCost <= node.fCost;
            }
        }
    }
}
