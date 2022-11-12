using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Data;
using System.Drawing;

namespace ValhallaV.Server
{
    public class Checkpoints : IScript
    {
        private ICheckpoint _demoCheckpoint;

        public Checkpoints()
        {
            // Register Event Handler
            Alt.OnCheckpoint += Alt_OnCheckpoint;

            // Erstellt einen neuen Checkpoint
            _demoCheckpoint = Alt.CreateCheckpoint(CheckpointType.Cyclinder, new Position(412.16702f, -975.9429f, 28.414673f), 1.5f, 2f, Color.Yellow);
        }

        private void Alt_OnCheckpoint(ICheckpoint checkpoint, IEntity entity, bool state)
        {
            if (checkpoint != _demoCheckpoint) return;

            if (state)
            {
                Alt.Log($"Checkpoint {checkpoint} betreten!");
            }
            else
            {
                Alt.Log($"Checkpoint {checkpoint} verlassen!");
            }
        }
    }
}
