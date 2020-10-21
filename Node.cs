namespace LinkedListDemo
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Node<T>
    {
        public T data;
        public Node<T> next;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public Node(T data)
        {
            this.data = data;
        }
    }
}
