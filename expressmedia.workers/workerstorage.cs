using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expressmedia.workers
{
    /// <summary>
    /// Emulates a storage to hold sets of operations in the memory
    /// </summary>
    public class WorkerStorage
    {
        private readonly Dictionary<string, Worker> _workers; // holds workers

        public WorkerStorage()
        {
            _workers = new Dictionary<string, Worker>();
        }

        /// <summary>
        /// Registers the worker in storage
        /// </summary>
        /// <param name="worker"></param>
        /// <returns></returns>
        public bool RegisterWorker(Worker worker)
        {
            if (_workers.ContainsKey(worker.Name))
                return false;

            _workers.Add(worker.Name, worker);
            return true;
        }

        /// <summary>
        /// Gets all workers registered
        /// </summary>
        /// <returns></returns>
        public List<Worker> GetWorkers()
        {
            return _workers.Values.ToList();
        }

        /// <summary>
        /// Return the worker by name or null if not found
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Worker GetWorker(string name)
        {
            return (_workers.ContainsKey(name)) ? _workers[name] : null;
        }
    }
}
