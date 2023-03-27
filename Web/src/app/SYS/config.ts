export class Config {

  agentsendpoint : string | undefined
  mapsendpoint : string | undefined
  teamsendpoint : string | undefined
  playersendpoint : string | undefined
  matchsendpoint : string | undefined
  loginendpoint : string | undefined

  private static _current : Config  
  public static get Current() : Config {
    if (!this._current)
      this._current = this.LoadConfig()
    return this._current
  }
  
  private static LoadConfig() : Config
  {
    let config = new Config()
    config.agentsendpoint = '/api/agents'
    config.mapsendpoint = '/api/maps'
    config.teamsendpoint = '/api/teams'
    config.playersendpoint = '/api/players'
    config.matchsendpoint = '/api/matches'
    config.loginendpoint = '/api/login'
    return config
  }  
}