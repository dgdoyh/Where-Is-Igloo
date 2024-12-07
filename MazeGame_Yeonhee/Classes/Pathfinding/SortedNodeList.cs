// Assignment #: 10
// Full Name: Yeonhee Do
// Student ID: 2211198
// Version #: 2
// Submission Date: 2023-12-16

using System;
using System.Collections.Generic;
using System.Linq;

namespace MazeGame_Yeonhee.Classes.Pathfinding
{
    class SortedNodeList
    {
        List<Node> nodeList;

        public int Count
        {
            get { return nodeList.Count; }
        }

        public SortedNodeList()
        {
            nodeList = new List<Node>();
        }

        public void Add(Node node)
        {
            nodeList.Add(node);
        }

        public Node GetNode(int index)
        {
            return nodeList[index];
        }

        public void RemoveAt(int index)
        {
            nodeList.RemoveAt(index);
        }

        public int GetIndexOf(Node node)
        {
            // Get the index of the node
            for (int i = 0; i < nodeList.Count; i++)
            {
                Node currNode = nodeList[i];
                if (currNode.IsMatch(node)) return i;
            }

            // If there's no matched node,
            return -1;
        }

        public Node TakeOutNode()
        {
            // Get the best node (smallest FCost)
            if (nodeList.Count > 0)
            {
                Node bestNode = nodeList[0];
                foreach (Node node in nodeList)
                {
                    if (node.FCost < bestNode.FCost)
                    {
                        bestNode = node;
                    }
                }

                nodeList.Remove(bestNode);
                return bestNode;
            }
            return null;
        }
    }
}
