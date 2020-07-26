using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Exiled.API.Interfaces;

namespace CustomBroadcast
{
    public class Config : IConfig
    {

        public bool IsEnabled { get; set; } = true;

        public string[] CustomBroadcastMessage { get; set; } = "<color=#00FFFF>Заходи в дискорд этого сервера. Там ты можешь ознакомиться с правилами сервера и иногда поучаствовать в конкурсах - </color><color=red>discord.gg/BYQ4DS7</color>|<color=#00FFFF>В комплексе обитает <color=red>SCP-575</color>. Советую найти <color=red>фонарик</color>.</color>|<size=32><color=#00FFFF>У этого сервера абсолютно <color=red>другие правила</color>. Тут тебя не забанят если ты школьник или за то что убил админа. Все имеют <color=red>одинаковые права</color>. Подробнее в <color=red>INFO</color> или в <color=red>Discord'е</color>.</color></size>|<color=#00FFFF>Играя за зомби ты можешь ударить человека и <color=red>заразить его</color> с 40% вероятностью <color=red>Z вирусом</color>.</color>|<color=#00FFFF>Если стоять AFK(на месте) <color=red>больше 5 минут</color> то сервер вас переведёт за наблюдателей, а вместо вас будет другой игрок.</color>|<color=#00FFFF>Почти все SCP отлично <color=red>видят в темноте</color>.</color>|<color=#00FFFF><color=red>Z вирус</color> довольно быстро убивает и если не вылечиться игрок <color=red>превратится в SCP-049-2(Зомби)</color> и сам сможет <color=red>заражать</color> игроков.</color>|<color=#00FFFF>Если нравится концепция этого сервера то можешь купить админ права. Но нужно будет сдать тест на знание правил. Подробнее в <color=red>INFO</color> или в <color=red>Discord'е</color>.</color>|<color=#00FFFF>Чтобы спастись от <color=red>SCP-575</color> надо находиться в <color=red>освещённом помещении</color> или держать в руках <color=red>фонарик</color>.</color>|<color=#00FFFF>Если вам нравится этот сервер вы можете получить <color=red>бесплатно</color> цветной ник и тег. Подробнее в <color=red>INFO</color> или в <color=red>Discord'е</color> этого сервера.</color>|<color=#00FFFF>Вылечиться от <color=red>Z вируса</color> можно с помощью любой аптечки(не путать с бустами) с вероятностью <color=red>100%</color> за одно применение.</color>|<color=#00FFFF>На этом сервере MTF могут связать наручниками Chaos Insurgency. А Chaos Insurgency могут связать MTF. В итоге их можно обратить за другую команду.</color>|<color=#00FFFF><size=32>Для самых новичков. Кнопка <color=red>INFO</color> находится около <color=red>счётчика игроков</color> или кнопки <color=red>Войти(JOIN)</color>. \nТам есть ссылки для связи с администрацией, <color=red>Discord</color>, а так же информация которая <color=red>поможет освоиться на сервере</color> чтобы реже получать баны.</size></color>|<color=#00FFFF><color=red>SCP-173</color> и <color=red>SCP-939</color> имеют существенные улучшения на этом сервере.</color>|<color=#00FFFF>Чем дольше и чем больше игроков смотрят на <color=red>SCP-173</color> тем чаще он двигается.</color>|<color=#00FFFF><size=32><color=red>SCP-939</color> быстрее людей примерно в <color=red>1,5 раза</color>. \nЧем больше ты будешь наносить урон по <color=red>SCP-939</color>, тем больше у него копится гнева. Чем больше гнева, тем больше урона с одного удара. \nПосле того как <color=red>SCP-939</color> кого-либо ударит, он будет замедлен на <color=red>3 секунды</color>.</size></color>|<color=#00FFFF><color=red>SCP-939</color> на улице видит игроков даже если они не подают признаков жизни.</color>".Split('|');

        public int RepeatingCooldown { get; set; } = 80;

        public int RepeatingDuration { get; set; } = 15;

    }
}
