using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Source.Build.Pipeline.Pipelines
{
    public class Pipeline : IEnumerable<IPipelineElement>
    {
        List<IPipelineElement> elements;

        public Pipeline()
        {
            elements = new List<IPipelineElement>();
        }

        public void Add(IPipelineElement element)
        {
            elements.Add(element);
        }

        public void Remove(IPipelineElement element)
        {
            elements.Remove(element);
        }

        public IEnumerator<IPipelineElement> GetEnumerator()
        {
            return ((IEnumerable<IPipelineElement>)elements).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<IPipelineElement>)elements).GetEnumerator();
        }

        public IPipelineElement this[int index]
        {
            get { return elements[index]; }
        }
    }
}
