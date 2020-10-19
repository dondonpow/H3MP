using BepInEx.Configuration;

namespace H3MP
{
	public class ClientConfig
	{
		public ClientPuppetConfig Puppet { get; }

		public ClientConfig(ConfigFile config, string section)
		{
			Puppet = new ClientPuppetConfig(config, section + "." + nameof(Puppet));
		}
	}
}