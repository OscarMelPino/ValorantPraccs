

interface IAgent {
    AgentID : number,
    AgentName : string,
    AgentRole : string
}

export class Agent implements IAgent {
    AgentID : number
    AgentName : string
    AgentRole : string

    constructor( id: number, name : string, role : string) {
        this.AgentID = id
        this.AgentName = name
        this.AgentRole = role
    }
}