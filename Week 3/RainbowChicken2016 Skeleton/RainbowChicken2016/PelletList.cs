﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace RainbowChicken2016
{
    public class PelletList
    {
        Pellet headPointer = null;
        Pellet tailPointer = null;

        Rectangle boundsRectangle;

        //==============================================================================
        // Ctor
        //==============================================================================
        public PelletList(Rectangle boundsRectangle)
        {
            this.boundsRectangle = boundsRectangle;
        }

        //==============================================================================
        // Add Pellet newPellet at the end of the list.
        //==============================================================================
        public void addPellet(Pellet newPellet)
        {
            if (headPointer == null)
            {
                headPointer = newPellet;
                tailPointer = newPellet;
            }
            else
            {
                tailPointer.Next = newPellet;
                tailPointer = newPellet;
            }           
        }

        //==============================================================================
        // Walk the list, counting the number of Pellet. Return the count.
        //==============================================================================
        public int Count()
        {
            int count = 0;
            Pellet nodeWalker = headPointer;

            while (nodeWalker != null)
            {
                count++;
                nodeWalker = nodeWalker.Next;
            }
            return count;
        }

        //==============================================================================
        // Walk the list, calling the Move() method of each Pellet
        //==============================================================================
        public void Move()
        {            
            Pellet nodeWalker = headPointer;

            while (nodeWalker != null)
            {
                nodeWalker.Move();
                nodeWalker = nodeWalker.Next;
            }            
        }

        //==============================================================================
        // Walk the list. For each Pellet, call TestOutOfBounds, passing boundsRectangle.
        // For each node that is out of bounds, set its IsAlive property to false.
        //==============================================================================
        public void KillOutOfBounds()
        {
            Pellet nodeWalker = headPointer;

            while (nodeWalker != null)
            {
                if (nodeWalker.TestOutOfBounds(boundsRectangle))
                {
                    nodeWalker.IsAlive = false; //Kill out of bounds pellet
                }
                nodeWalker = nodeWalker.Next;
            }   
        }

        //==============================================================================
        // Delete the argument Pellet pelletToDelete from the list.
        // Be careful to maintain the integrity of the list, including
        // headPointer and tailPointer.
        //==============================================================================
        public void DeleteOne(Pellet pelletToDelete)
        {
            Pellet nodeWalker = headPointer;
            if (pelletToDelete == headPointer)
            {
                if (pelletToDelete != tailPointer)
                {
                    headPointer = pelletToDelete.Next;
                }
                else
                {
                    headPointer = null;
                    tailPointer = null;
                }
            }
            else
            {
                    while (nodeWalker != null) 
                    {    
                        if (nodeWalker.Next == tailPointer)
                        {
                            tailPointer = nodeWalker;
                        }

                        if (nodeWalker.Next == pelletToDelete)
                        {
                            nodeWalker.Next = pelletToDelete.Next;
                        } 
                        nodeWalker = nodeWalker.Next;
                    }                
            }

            //My first attempt that failed
            //Pellet nodeWalker = headPointer;
            //Pellet previousPellet = null;
            //if ((pelletToDelete != headPointer) && (pelletToDelete != tailPointer))
            //{
            //    if (pelletToDelete == nodeWalker)
            //    {
            //        headPointer = pelletToDelete.Next;
            //    }
            //    else
            //    {
            //        while (nodeWalker.Next != pelletToDelete)
            //        {
            //            previousPellet = nodeWalker;
            //            nodeWalker = nodeWalker.Next;

            //            if (nodeWalker.Next == pelletToDelete)
            //            {
            //                nodeWalker.Next = pelletToDelete.Next;

            //                if (pelletToDelete == tailPointer)
            //                {
            //                    tailPointer = previousPellet;
            //                }
            //            }

            //        }
            //    }
            //}
            //else
            //{
            //    headPointer = null;
            //    tailPointer = null;
            //}    
           
        }

        //==============================================================================
        // Walk the list, deleting all nodes whose IsAlive propoerty is false
        //==============================================================================
        public void DeleteNotAlive()
        {
            Pellet nodeWalker = headPointer;

            while (nodeWalker != null)
            {
                if (nodeWalker.IsAlive == false)
                {
                    DeleteOne(nodeWalker);                    
                }

                nodeWalker = nodeWalker.Next;
            }   
        }

        //==============================================================================
        // Walk the list, calling each node's Draw method
        //==============================================================================
        public void Draw()
        {
            Pellet nodeWalker = headPointer;

            while (nodeWalker != null)
            {
                nodeWalker.Draw();
                nodeWalker = nodeWalker.Next;
            }   
        }
    }
}
