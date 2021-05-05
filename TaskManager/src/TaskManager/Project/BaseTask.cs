using System;
using System.Linq;

namespace ProjectLibrary
{
    [Serializable]
    public abstract class BaseTask
    {
        /// <summary>
        /// Field task name.
        /// </summary>
        private string _name;

        /// <summary>
        /// Property task name.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                value = value.Trim();
                if (!NameValidator(value))
                {
                    throw new ArgumentException("The name must contain only Latin letters, digits and spaces.");
                }

                _name = value;
            }
        }

        /// <summary>
        /// Check task name for valid.
        /// </summary>
        /// <param name="name">Checking name.</param>
        /// <returns>Result of checking.</returns>
        private static bool NameValidator(string name)
        {
            return !string.IsNullOrEmpty(name) && name.All(letter =>
                letter > 'A' - 1 && letter < 'Z' + 1
                || letter > 'a' - 1 && letter < 'z' + 1
                || char.IsWhiteSpace(letter)
                || char.IsDigit(letter)
            );
        }

        /// <summary>
        /// Property task owner.
        /// </summary>
        public BaseTask Owner { get; set; }
        
        /// <summary>
        /// Property task creation date time.
        /// </summary>
        public DateTime CreationDateTime { get; set; }

        /// <summary>
        /// Property task current state.
        /// </summary>
        public State State { get; set; }

        /// <summary>
        /// Property task type.
        /// </summary>
        public TypeTask TypeTask { get; set; }

        /// <summary>
        /// Constructor only for json.
        /// </summary>
        protected BaseTask()
        {
        }

        /// <summary>
        /// BaseTask constructor.
        /// </summary>
        /// <param name="name">Task name.</param>
        /// <param name="typeTask">Task type.</param>
        protected BaseTask(string name, TypeTask typeTask)
        {
            Name = name;
            Owner = this;

            CreationDateTime = DateTime.Now;

            State = State.Open;
            TypeTask = typeTask;
        }

        /// <summary>
        /// Get task if there is one.
        /// </summary>
        /// <param name="index">Task index.</param>
        /// <returns>Task.</returns>
        public abstract BaseTask GetTask(int index);

        /// <summary>
        /// Change task state.
        /// </summary>
        /// <param name="state">New task.</param>
        public virtual void ChangeState(State state) => State = state;
        
        /// <summary>
        /// Get task info.
        /// </summary>
        /// <returns>Task info.</returns>
        public override string ToString()
        {
            return $"Name: {Name}; Creation Date: {CreationDateTime}; " +
                   $"State: {State}; Type: {TypeTask}";
        }
    }
}