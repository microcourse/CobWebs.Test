using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using CobWebs.Test.Abstraction;
using CobWebs.Test.Domain;

namespace CobWebs.Test
{
    public class BasketGame: IBasketGame
    {
        private readonly BasketGameConfig _config;
        private readonly IPlayerFactory _playerFactory;

        public BasketGame(IPlayerFactory playerFactory, BasketGameConfig config)
        {
            this._playerFactory = playerFactory ?? throw new ArgumentNullException(nameof(config));
            this._config = config ?? throw new ArgumentNullException(nameof(config));
        }

        public void Start(int basketWeight, IEnumerable<BasketPlayerSpecification> items)
        {
            var history = new List<int>();
            var playersSpec = (items ?? new BasketPlayerSpecification[0]).ToArray();

            if (playersSpec.Length < 3 || playersSpec.Length > 8)
            {
                throw new ArgumentException(nameof(items));
            }

            var playerStates = playersSpec
                .Select(x => _playerFactory.Create(x, _config))
                .Select(x=> new BasketPlayerState{ Player = x})
                .ToArray();


            
            var timer = new Stopwatch();
            var context = new BasketGameContext
            {
                RealBasketWeight = basketWeight,
                Players = playerStates
            };

            BasketPlayerState winnerState = null;

            timer.Start();

            do
            {
                winnerState = TryGetWinner(context);

                if (winnerState != null)
                {
                    break;
                }

            } while (context.Attempts < _config.MaxAttempts &&
                     timer.Elapsed < _config.MaxTime);


            Console.WriteLine($"The real weight of the basket: {basketWeight}.");
            if (winnerState != null)
            {
                Console.WriteLine($"Winner name {winnerState.Player} total amount of attempts {winnerState.Attempts}.");
                return;
            }
        }

        private static BasketPlayerState TryGetWinner(BasketGameContext context)
        {
            BasketPlayerState winnerState = null;

            foreach (var state in context.Players)
            {
                Thread.Sleep(state.Timeout);

                var playerContext = new BasketPlayerContext(context.Answers);
                var weight = state.Player.GetAnswer(playerContext);
                
                if (weight == context.RealBasketWeight)
                {
                    winnerState = state;
                    break;
                }

                state.Timeout = TimeSpan.FromMilliseconds(Math.Abs(context.RealBasketWeight-weight));
                
                context.Answers.Add(weight);
                context.Attempts++;
            }

            return winnerState;
        }
    }
}
