namespace Composite
{
	using System.Collections;
	using System.Collections.ObjectModel;


	/// <summary>
	/// Example for neural networks where a neuron can be connected to other neurons. A layer is a collection of neurons. You can connect layers to layers, layers to neurons, neurons to layers, neurons to neurons.
	/// </summary>
	public class Neuron : IEnumerable<Neuron>
	{
		public float Value;
		public List<Neuron> In, Out;
		// init list
		public Neuron(float value)
		{
			Value = value;
			In = new List<Neuron>();
			Out = new List<Neuron>();
		}

		public IEnumerator<Neuron> GetEnumerator()
		{
			yield return this;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			yield return this;
		}

		// add an iterator to iterate over the neurons linked the values to the next layer and return it in a string
		public override string ToString()
		{
			return string.Join(",", Out.Select(n => n.Value)) + " => " + Value;
		}

	}

	public class NeuronLayer : Collection<Neuron>
	{

	}


	public static class ExtensionMethods
	{
		public static void ConnectTo(this IEnumerable<Neuron> self, IEnumerable<Neuron> other)
		{
			if (ReferenceEquals(self, other)) return;

			foreach (var from in self)
			{
				foreach (var to in other)
				{
					from.Out.Add(to);
					to.In.Add(from);
				}
			}
		}
	}

}