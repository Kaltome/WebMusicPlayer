using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicPlayer.Models;

namespace MusicPlayer.Services.MusicPlayer
{
    public class MusicRepository
    {
        public static List<Music> getMusic()
        {
            return new List<Music>
            {
                new Music()
                {
                    no = 0,
                    name = "DESIRE OVER DOSE.mp3",
                    title ="DESIRE OVER DOSE",
                    artist = "魂音泉",
                    album = "TOSX TOKYO at clubasia",
                    albumImg = "TOSX TOKYO.png",
                    duration = "04: 38",
                    musicDescription = new MusicDescription
                    {
                        title = "头图专用曲",
                        //title ="Head-image-Only Music",
                        //description = "It's indeed a pretty first song recommended by the design master, JP. So overbearing the cover is, which has improved my ugly player by several grades.\n\nHowever, It's a pity that it's just a first song. Few of us like the style of the song, only JP himself."
                        description = "不愧是设计大师JP推荐的播放器头曲，封面可真是霸气呢，让我本身丑陋的播放器提升了好几个档次。\n\n不过令人可惜，这仅仅是个头曲罢了，曲子的风格，我们没几个人是喜欢的，只有JP他自己。"
                    }
                },

                new Music()
                {
                    no = 1,
                    name = "Flower Dance.mp3",
                    albumImg = "FlowerDance.jpg",
                    album = "kaleidoscope",
                    artist = "DJ OKAWARI",
                    title = "Flower Dance",
                    duration="04: 28",
                    musicDescription = new MusicDescription
                    {
                        title = "必不可缺的高雅钢琴",
                        description = "要不是封面色调黄了点，优雅的琴声配上充满艺术气息的封面，是当头曲的好选择。\n\n哪怕自己是垃圾，高雅也是要装一装的，虽然有一种民科大喊推翻相对论要获诺奖的味道。"
                    }
                },

                new Music()
                {
                    no = 2,
                    name = "上海红茶馆 ~ Chinese Tea.mp3",
                    title ="上海红茶馆 ~ Chinese Tea",
                    artist = "上海アリス幻樂団",
                    album = "夢違科学世紀　～ Changeability of Strange Dream",
                    albumImg = "ZCDS-0003.jpg",
                    duration = "05: 15",
                    musicDescription = new MusicDescription
                    {
                        title = "ZUNの音乐正作",
                        description = "神主就完事了。\n\n当然，这或许和我用过此曲做过某搞笑（划掉，是神主模式）视频有关。总之在神主的专辑中我自己相对喜欢这一首，就扔上去了。"
                    }
                },

                new Music()
                {
                    no = 3,
                    name = "Over the moon.mp3",
                    title ="Over the moon",
                    artist = "だ, ポール",
                    album = "梦视京",
                    albumImg = "Mengshijing.jpg",
                    duration = "03: 21",
                    musicDescription = new MusicDescription
                    {
                        title = "ZUNの同人音乐",
                        description = "西洋的长笛真是悦耳，令人陶醉。一直想接触，然而应该是没有机会了。\n\n对于艺术，时间和天赋是不可或缺的。"
                    }
                },

                new Music()
                {
                    no = 4,
                    name = "Cirno_v1.wav",
                    title ="おてんば恋娘",
                    artist = "JP",
                    album = "FL即兴小作",
                    albumImg = "JP.jpg",
                    duration = "00: 21",
                    musicDescription = new MusicDescription
                    {
                        title = "冰湖上的舞蹈",
                        description = "JP残存的即兴练习曲之一。\n\n可惜他的天赋了，这可是他接触音乐仅一天的作品。"
                    }
                },

                new Music()
                {
                    no = 5,
                    name = "啊.wav",
                    title ="啊♂",
                    artist = "JP",
                    album = "哲学幽情",
                    albumImg = "JP.jpg",
                    duration = "00: 29",
                    musicDescription = new MusicDescription
                    {
                        title = "愉快的射恋恋之旅",
                        description = "啊♂ 啊♂ 啊♂  啊♂啊♂ 啊♂啊♂ 啊♂ 啊♂  啊♂  啊♂啊♂ 啊♂ 啊♂ 啊♂ 啊♂ 啊♂ 啊♂  啊♂啊♂啊♂啊♂啊♂啊♂啊♂  啊♂ 啊♂啊♂"
                    }
                },

                new Music()
                {
                    no = 6,
                    name = "吔苹果.wav",
                    title ="吔苹果",
                    artist = "JP",
                    album = "鬼畜小配音",
                    albumImg = "JP.jpg",
                    duration = "00: 17",
                    musicDescription = new MusicDescription
                    {
                        //\n\n圣皇的世界，凡人是无法了解的。被圣皇脑海中游荡的艺术气息包围，虽然对于音痴来讲是一片朦胧
                        title = "梁非凡一边睇玩具熊一边吔苹果",
                        description = "JP为我鬼畜配音的小作品，梁非凡，小苹果，玩具熊，天作之合。\n\n愉快的中学时期与纯真的激情一去不复返。"
                    }
                },

                new Music()
                {
                    no = 7,
                    name = "fuck♂.mp3",
                    title ="Fuck♂",
                    artist = "JP",
                    album = "哲学幽情",
                    albumImg = "JP.jpg",
                    duration = "00: 07",
                    musicDescription = new MusicDescription
                    {
                        //\n\n圣皇的世界，凡人是无法了解的。被圣皇脑海中游荡的艺术气息包围，虽然对于音痴来讲是一片朦胧
                        title = "Fuck兔子？Fuck美国小丑？Fuck千年狐狸？",
                        description = "fuck♂ fuck♂ fuck♂ fuck♂ fuck♂ fuck♂ fuck♂fuck♂fuck♂fuck♂fuck♂ fuck♂ fuck♂ fuck♂ fuck♂ fuck♂ fuck♂fuck♂fuck♂fuck♂"
                    }
                },

                new Music()
                {
                    no = 8,
                    name = "Music Lab Remix Billie Eilish.m4a",
                    title ="Music Lab Remix Billie Eilish",
                    artist = "莫圣皇",
                    album = "Music Lab Remix",
                    albumImg = "moshenghuang.jpg",
                    duration = "03: 05",
                    musicDescription = new MusicDescription
                    {
                        //\n\n圣皇的世界，凡人是无法了解的。被圣皇脑海中游荡的艺术气息包围，虽然对于音痴来讲是一片朦胧
                        title = "天才歌手背后的圣光",
                        description = "谁能轻松地驾驭美国天才歌手，词曲作家Billie Eilish喉间呼出的仙音？谁能默契地把冰冷无情的库音色和全球超级新人独特的艺术细胞交织融合？\n\n年轻的Billie Eilish从未想过，她被一位圣皇关注着。"
                    }
                },

                new Music()
                {
                    no = 9,
                    name = "圣皇小调.m4a",
                    title ="圣皇小调",
                    artist = "莫圣皇",
                    album = "Music Lab Remix",
                    albumImg = "moshenghuang2.jpg",
                    duration = "00: 15",
                    musicDescription = new MusicDescription
                    {
                        title = "圣皇的悠情小调",
                        description = "她说是用库音乐xjb敲的，你信吗？"
                    }
                },

                new Music()
                {
                    no = 10,
                    name = "Tansdown.mp3",
                    title ="Tansdown",
                    artist = "Kaltome",
                    album = "RubbIsh",
                    albumImg = "ops.png",
                    duration = "01: 51",
                    musicDescription = new MusicDescription
                    {
                        title = "废才能随心所欲吗？",
                        description = "用自带诡异的MIDI瞎几把敲的的曲子，可惜找不到什么好的和声伴奏。虽然全部自创，但也就这样，一般般吧，毕竟自己什么都不会。"
                    }
                },

                new Music()
                {
                    no = 11,
                    name = "Fantasia_End.mp3",
                    title ="Fantasia_End",
                    artist = "Kaltome",
                    album = "RubbIsh",
                    albumImg = "ops.png",
                    duration = "01: 10",
                    musicDescription = new MusicDescription
                    {
                        //\n\n圣皇的世界，凡人是无法了解的。被圣皇脑海中游荡的艺术气息包围，虽然对于音痴来讲是一片朦胧
                        title = "终符之后",
                        description = "利用八云紫本身主旋律的和声伴奏作为铺垫，配以急速的钢琴，再衔接原本的高潮，是否营造出了一种击破后，真正的弹幕结界才正式降临的氛围？\n\n除了铺垫的和声伴奏，前半部分都是自己尝试的，也算个了结吧。\n\n" +
                        "可惜，垃圾再怎么燃烧激情的焰火，最后都只是污染空气而已。"
                      
                    }
                },

                new Music()
                {
                    no = 12,
                    name = "Remote_160710.wav",
                    title ="ラストリモート",
                    artist = "JP",
                    album = "FL即兴小作",
                    albumImg = "JP.jpg",
                    duration = "00: 41",
                    musicDescription = new MusicDescription
                    {
                        title = "探逐恋之瞳",
                        description = "古明地恋闭合的第三只眼或许正是JP闭合的音乐之心。"
                    }
                },
            };
        }
    }
}
