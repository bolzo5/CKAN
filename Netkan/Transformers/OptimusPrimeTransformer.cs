using System.Collections.Generic;
using log4net;
using Newtonsoft.Json.Linq;
using CKAN.NetKAN.Model;

namespace CKAN.NetKAN.Transformers
{
    internal sealed class OptimusPrimeTransformer : ITransformer
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(OptimusPrimeTransformer));

        public string Name { get { return "optimus_prime"; } }

        public IEnumerable<Metadata> Transform(Metadata metadata, TransformOptions opts)
        {
            var json = metadata.Json();

            JToken optimusPrime;
            if (json.TryGetValue("x_netkan_optimus_prime", out optimusPrime) && (bool)optimusPrime)
            {
                Log.Info("Autobots roll out!");
            }

            yield return metadata;
        }
    }
}
