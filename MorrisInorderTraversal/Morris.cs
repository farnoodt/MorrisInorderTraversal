using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorrisInorderTraversal
{
    class Morris
    {
        public void MorrisTraversal(Node root)
        {
            Node current, pre;

            if (root == null)
                return;

            current = root;
            while (current != null)
            {
                if (current.left == null)
                {
                    Console.Write(current.data + " ");
                    current = current.right;
                }
                else
                {
                    pre = current.left;
                    while (pre.right != null && pre.right != current)
                        pre = pre.right;

                    if (pre.right == null)
                    {
                        pre.right = current;
                        current = current.left;
                    }
                    else
                    {
                        pre.right = null;
                        Console.Write(current.data + " ");
                        current = current.right;
                    } 
                } /* End of if condition current->left == NULL*/

            } /* End of while */
        }
    }
}
